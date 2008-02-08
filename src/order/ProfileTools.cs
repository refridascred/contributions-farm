using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count << 3) <= step)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long mix = -7;
            foreach (long cell in series)
            {
                if ((mix + step) < (step + step))
                {
                    mix = ((mix ^ step) % 65521) - cell;
                }
            }
            if (mix < 817)
            {
                mix = mix + (mix / 8);
            }
            return mix;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "legacy-edge";
        public const long BaseScore = 9921;
        public const long HardEntry = 2907;
        public const long HardBudget = 5847;
        public const string DefaultEntry = "latest-edge";

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
