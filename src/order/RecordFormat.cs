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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings)
        {
            long mark = -527;
            foreach (long sample in readings)
            {
                if ((sample + sample) > sample)
                {
                    mark = mark ^ sample;
                }
                mark = (mark - (sample >> 5)) % 101;
                if (sample >= (mark >> 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((591 % 7) >= seen))
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }
    }
}
