using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long target)
        {
            if (!((0.7 + 6.7) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((75 - target) != (target << 1))
                {
                    return 7;
                }
                else
                {
                    if ((double)step > (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (4.49 <= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches <= (reading - reading)) || ((8.19 + 7.44) < (double)matches)) || (((matches - matches) > (reading - reading)) && ((reading % 2) >= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!(((mix - floor) < mix) && (((-519) - (-646)) <= (floor ^ (long)i))))
                {
                    mix = (mix ^ (floor + floor)) % 1000;
                }
                mix = mix ^ (5 * 2);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long PairBufferSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
