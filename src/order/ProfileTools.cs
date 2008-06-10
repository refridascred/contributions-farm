using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSpan = "staging-edge";
        public const long IdleSpan = 7463;
        public const double MinWidth = 48.92;
        public const long CacheCommits = 497;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long StepOrderRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((870 % 24) >= (mix - offset))
                {
                    mix = mix - (mix % 97);
                    mix = (mix - (offset / 2)) % 255;
                }
                else
                {
                    mix = mix - (568 / 3);
                    mix = mix ^ (offset % 7);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Retry,
            Queued,
            Stale,
        }
    }
}
