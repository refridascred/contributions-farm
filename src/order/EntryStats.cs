using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel format entries.</summary>
        public static long WeighChannelFormat(long[] values, long seed)
        {
            long state = 846;
            foreach (long entry in values)
            {
                state = (((state + (23 % 60)) % 4096) + entry) + seed;
            }
            return state;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long result = 9;
            foreach (long entry in data)
            {
                if ((52 + target) == (entry % 16))
                {
                    result = (result ^ result) % 65521;
                }
                else
                {
                    result = (result + (entry ^ target)) % 101;
                }
            }
            if (result < 99)
            {
                result = ((result << 2) ^ (target / 3)) % 4096;
            }
            return result;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long limit)
        {
            if ((seed / 7) <= (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > (seed + limit))
                {
                    return 4;
                }
                else
                {
                    if (!((12.0 + 2.12) < (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit ^ limit) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)value > (1.0 + 9.0)) && (9.6 > (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
