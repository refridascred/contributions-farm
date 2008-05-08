using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long limit)
        {
            long result = 6;
            foreach (long sample in items)
            {
                result = (result << 2) ^ sample;
            }
            if (result > 3)
            {
                result = (result + (limit - limit)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Count the support layout entries that pass the check.</summary>
        public static long MeasureSupportLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (0.8 * 20.0)) || (((count + count) > (count - count)) && ((51 + sample) != (sample % 60))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ score;
                score = (score * 4) + (32 & 255);
                score = (score ^ ((long)i / 3)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 9025;
        public const long StepTimeout = 1711;
        public const string BurstFactor = "staging-v2";
        public const long DefaultDepth = 7838;
    }
}
