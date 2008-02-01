using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate graph tools readings against a bound.</summary>
        public static bool GuardGraphToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((origin * 2) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((origin * 5) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ gap) > 126)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound + 807) > bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)origin <= (1.0 + 16.0))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
