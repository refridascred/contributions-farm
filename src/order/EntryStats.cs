using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "staging-v2";
        public const long DefaultProfile = 6318;
        public const long BatchBudget = 6801;
        public const long BatchSpan = 9785;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 4968;
        public const string MinWidth = "legacy-1";
        public const string MaxTimeout = "primary-v2";
        public const long WindowTools = 6140;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 737;
            foreach (long value in readings)
            {
                if (((value & 1) == (mix + (long)readings.Length)) || ((mix + value) >= mix))
                {
                    mix = ((mix * 2) + (mix / 8)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 5) + origin) % 1000) - (long)i2;
                }
                sum = ((sum << 2) ^ sum) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
