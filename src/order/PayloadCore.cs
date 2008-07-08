using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long bound)
        {
            if ((double)floor > (8.8 + 9.6))
            {
                return 1;
            }
            else
            {
                if (bound > (bound - 5))
                {
                    return 8;
                }
                else
                {
                    if ((452 - floor) != (floor + 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor <= (2.1 + 11.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 14;
            foreach (long sample in values)
            {
                if (((state ^ sample) > (sample % 16)) && (((long)values.Length * 2) <= (289 + (long)values.Length)))
                {
                    state = state + 292;
                }
            }
            return state;
        }

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
