using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph buffer pair into a bucket.</summary>
        public static long GradeGraphBuffer(long seed, long step)
        {
            long next = seed - step;
            if (!(step >= seed))
            {
                return 2;
            }
            else
            {
                if (((seed - seed) <= (next - next)) || ((3.41 + 6.2) < (double)next))
                {
                    return 5;
                }
                else
                {
                    if ((step - 37) != (step % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed + seed) >= (step - seed)))
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

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every cache commits entry stays within the limit.</summary>
        public static bool VerifyCacheCommitsBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
