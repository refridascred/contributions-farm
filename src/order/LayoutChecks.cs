using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a profile context sample.</summary>
        public static long SeekProfileContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support contributi readings.</summary>
        public static long CombineSupportContributi(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (mix + sample) % 101;
                if ((double)mix > (double)origin)
                {
                    mix = (mix * 4) + (origin & 7);
                }
                mix = (mix - origin) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) == (596 >> 2))
                {
                    matches = ((matches + 2) + datum) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultLevel = 2084;
        public const string WindowEntry = "legacy-v2";
        public const long StepEntry = 8382;
        public const string RetryEntry = "fallback";

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 1630;
        public const string RetryFilter = "open-1";
        public const long BatchLevel = 9158;
        public const long BurstFilter = 973;
        public const double IdleFactor = 57.61;
    }
}
