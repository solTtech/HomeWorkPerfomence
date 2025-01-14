using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._3
{
    public class MagicBag <T> where T : ICreature
    {
        private readonly Dictionary<string, (DateTime lastAccess, object gift)> _gifts = new();
        private readonly Func<T, object> _giftGenerator;

        public MagicBag(Func<T, object> giftGenerator)
        {
            _giftGenerator = giftGenerator ?? throw new ArgumentNullException(nameof(giftGenerator));
        }

        public object GetGift(T creature)
        {
            if (creature == null)
                throw new ArgumentNullException(nameof(creature));

            var creatureType = creature.CreatureType;
            var currentDate = DateTime.UtcNow.Date;

            // Якщо подарунок для цієї істоти вже видавався сьогодні, повертаємо його
            if (_gifts.TryGetValue(creatureType, out var existingGift) && existingGift.lastAccess.Date == currentDate)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Істота {creatureType} вже отримала подарунок сьогодні: ");
                return existingGift.gift;
            }

            // Генеруємо новий подарунок
            var newGift = _giftGenerator(creature);
            _gifts[creatureType] = (currentDate, newGift);
            Console.ResetColor();
            Console.WriteLine($"Істота {creatureType} отримує унікальний подарунок:");
            return newGift;
        }
    }
}
