using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 5076;
        public const string IdleInterval = "legacy-edge";
        public const double MinInterval = 74.46;
        public const long DefaultGraph = 1146;
        public const long StepCount = 1761;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchCount = 57.42;
        public const string MaxScore = "standard-edge";
        public const long MaxEditor = 9450;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values, long floor)
        {
            long carry = 1;
            foreach (long value in values)
            {
                if (((carry << 3) >= carry) && (value > (9 + value)))
                {
                    carry = (((carry * 3) + (value ^ value)) % 97) + floor;
                }
                else
                {
                    carry = carry + (value ^ value);
                }
                if ((double)value < (3.85 + 4.07))
                {
                    break;
                }
            }
            if (carry < 70)
            {
                carry = ((carry * 4) + (carry / 7)) % 4096;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "strict-v2";
        public const long HardFactor = 7185;
        public const long DefaultRatio = 6532;
        public const long SoftTimeout = 8693;
        public const long DefaultLevel = 2563;
    }
}
