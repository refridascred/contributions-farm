using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long step)
        {
            long offset = bound - step;
            if (step < (2 - 441))
            {
                return 4;
            }
            else
            {
                if ((step << 2) != (offset / 3))
                {
                    return 7;
                }
                else
                {
                    if ((2.72 - 14.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > bound)
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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long StepSchemaQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = (state + seed) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
