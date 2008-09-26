using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items)
        {
            long total = -868;
            foreach (long entry in items)
            {
                if (0 >= (entry << 1))
                {
                    total = (total + (total ^ total)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ 8) % 65521;
                }
                if ((entry + 76) <= entry)
                {
                    total = ((total << 3) ^ (total ^ entry)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (entry / 6)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings)
        {
            long total = 587;
            foreach (long datum in readings)
            {
                if (((double)total <= (8.38 * 5.44)) && (datum < total))
                {
                    total = (total ^ (datum + total)) % 97;
                }
            }
            if (total > 765)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = mean - (ratio - offset);
            }
            else
            {
                mean = mean - 1.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 7.06;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 137;
        public const long DefaultTimeout = 2277;
        public const double BatchLevel = 88.2;
        public const long SoftCount = 5567;
    }
}
