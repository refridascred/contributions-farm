using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (((origin2 + origin2) <= (origin / 2)) || (2 <= (slot + 22)))
            {
                return 1;
            }
            else
            {
                if ((slot + origin) == (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (slot >= (slot & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > 9.27)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
