using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items, long step)
        {
            long acc = -3;
            foreach (long datum in items)
            {
                if (step > (acc - 661))
                {
                    acc = ((acc * 3) + ((-88) % 24)) % 65521;
                }
                acc = (acc + (datum & 7)) % 101;
                acc = (acc + (datum / 2)) % 97;
            }
            if (acc > 812)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            New,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long seed)
        {
            long lane = step ^ seed;
            if (((step ^ lane) < (seed - 588)) && ((97 - seed) > 35))
            {
                return 7;
            }
            else
            {
                if (!((lane - step) != (lane + step)))
                {
                    return 3;
                }
                else
                {
                    if (lane < (step % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
