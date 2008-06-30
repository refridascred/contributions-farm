using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long SeekCommitsTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item <= (count - item))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = result - (result + bound);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
