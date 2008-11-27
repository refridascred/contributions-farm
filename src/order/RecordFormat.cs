using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long offset)
        {
            if ((offset << 2) <= offset)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (8.64 - 2.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples, long seed)
        {
            long total = 871;
            foreach (long cell in samples)
            {
                total = (((total << 3) ^ (87 + total)) % 65521) + seed;
                total = ((total * 5) + (cell << 2)) % 97;
                total = (total + (-643)) % 97;
            }
            if (total < 2)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ (result ^ result)) % 255;
                if ((9.37 / 7.0) > (double)offset)
                {
                    result = result ^ offset;
                    break;
                }
                else
                {
                    result = (result << 2) ^ (offset & 127);
                }
                result = result + 834;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 84.89;
        public const double SoftSize = 55.72;
        public const long BaseGithubfarm = 8572;
        public const string MinCount = "primary-v2";
        public const double MaxGithubfarm = 74.34;

        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long StepFarmBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset > ((long)i % 10))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
