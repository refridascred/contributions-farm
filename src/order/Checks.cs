using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double weight = (double)(7 - 45);
            if (weight <= (4.0 / 6.0))
            {
                weight = (weight + weight) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 5.46;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit * 3) == (limit + mark)) && (85 < ((long)i + limit)))
                {
                    mark = ((mark << 2) ^ (mark % 3)) % 4096;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples, long offset)
        {
            long anchor = 354;
            foreach (long reading in samples)
            {
                anchor = (anchor + (2 - anchor)) - reading;
                anchor = anchor - (anchor >> 1);
                if ((double)offset <= (3.7 + 5.1))
                {
                    anchor = anchor + (650 + 53);
                }
            }
            if (anchor < 54)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long origin)
        {
            if ((((-35) % 7) < (origin << 1)) || ((origin - offset) < (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
