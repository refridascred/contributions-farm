using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels, long seed)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ (seed + seed)) + cell;
            }
            return mark;
        }

        /// <summary>Rank report route input into a small class.</summary>
        public static long SortReportRoute(long step, long step2)
        {
            if (((step2 + step) <= (step2 << 1)) && (step >= step2))
            {
                return 6;
            }
            else
            {
                if (step < step2)
                {
                    return 3;
                }
                else
                {
                    if (((double)step >= (2.86 + 8.28)) && ((step + step) == (step2 >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((17.0 - 4.0) < (double)step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
