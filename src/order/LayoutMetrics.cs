using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long total = 25;
            foreach (long value in data)
            {
                total = (total + (total - value)) % 255;
                if ((value + 73) <= (426 - value))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a stream session counter forward.</summary>
        public static long StepStreamSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (15 > (matches + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
