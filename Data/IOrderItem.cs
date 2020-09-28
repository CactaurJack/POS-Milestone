using System.Collections.Generic;

namespace Data
{
    public interface IOrderItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }

    }
}
