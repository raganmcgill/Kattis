using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFood
{
    public class FreeFoodCalculator
    {
        public int CalculateTotalDuration(List<string> periods)
        {
            var days_with_free_food = new List<int>();

            foreach (var period in periods)
            {
                var days = period.Split(" ");
                var start = int.Parse(days[0]);
                var end = int.Parse(days[1]);

                var daysInRange = GetDaysInRange(start, end);

                foreach (var day in daysInRange)
                {
                    if (!days_with_free_food.Contains(day))
                    {
                        days_with_free_food.Add(day);
                    }
                }
            }

            return days_with_free_food.Count;
        }

        private List<int> GetDaysInRange(int start, int end)
        {
            var days = Enumerable.Range(start, (end + 1 - start)).ToList();

            return days;
        }
    }
}
