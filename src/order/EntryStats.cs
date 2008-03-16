using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two support queue measurements.</summary>
        public static double ScaleSupportQueue(double weight, double offset)
        {
            double gain = (double)(1 - 122);
            if (gain >= (weight - 0.6))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - 0.52;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + weight)) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long total = 4;
            foreach (long value in levels)
            {
                total = ((total << 2) ^ (value & 1)) % 1000;
                if ((total < (value << 1)) && ((8 - 42) >= value))
                {
                    total = (total - (total ^ total)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (value - value);
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (seed < (748 % 97))
            {
                return 1;
            }
            else
            {
                if (((seed / 5) <= (offset << 3)) || ((3.8 / 3.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((9.4 + 0.3) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >= (954 - bound)) && (seed >= (offset >> 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
