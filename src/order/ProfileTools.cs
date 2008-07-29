using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (2.29 + 19.0))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metric command values into a single score.</summary>
        public static long ScoreMetricCommand(long[] values)
        {
            long sum = 53;
            foreach (long cell in values)
            {
                if (cell < sum)
                {
                    sum = (sum ^ (sum + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
