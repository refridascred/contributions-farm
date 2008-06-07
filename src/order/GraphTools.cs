using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                long matches = (limit << 1) << 3;
                matches = matches - (84 + 8);
                mix = (mix ^ (matches + 605)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count > (target * 2))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long step)
        {
            long mark = 506;
            foreach (long value in values)
            {
                if (((mark ^ value) <= ((-510) + 929)) && (value <= (mark + step)))
                {
                    mark = ((mark << 3) ^ (18 - step)) % 65521;
                }
                if (value <= (mark % 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + total) % 101) ^ (long)i2;
                    total = total + (seed & 255);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
