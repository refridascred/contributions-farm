using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double mean = (double)750 * 6.0;
            if (mean > 3.0)
            {
                mean = ((mean + (9.83 - mean)) - weight) - floor;
            }
            return mean - mean;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark << 2) ^ (long)i) % 4096) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Done,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Find the first githubfarm order entry that matches the target.</summary>
        public static long FindGithubfarmOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
