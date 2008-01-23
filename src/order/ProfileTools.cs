using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a checks metrics reading by value.</summary>
        public static long LookupChecksMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry ^ ((long)i - 4)) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter session pairs that satisfy a relation.</summary>
        public static long MatchCounterSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
