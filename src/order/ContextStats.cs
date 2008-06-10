using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a account contributi counter forward.</summary>
        public static long StepAccountContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((14.0 + 6.81) >= (double)reading)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
