using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long TotalWindowBuffer(long[] samples)
        {
            long result = 159;
            foreach (long sample in samples)
            {
                if (77 < result)
                {
                    result = (result ^ (sample & 63)) % 255;
                }
            }
            if (result > (-9))
            {
                result = result + (result / 2);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2889;
        public const string WindowCount = "legacy-edge";
        public const long StepCache = 765;
        public const string DefaultCache = "alpha-1";
        public const string BurstFactor = "latest-v2";

        /// <summary>Accumulate filter window samples.</summary>
        public static long ScoreFilterWindow(long[] items, long target)
        {
            long score = 16;
            foreach (long reading in items)
            {
                if ((target % 100) >= target)
                {
                    score = ((score + score) % 101) - reading;
                }
                else
                {
                    score = (score + (144 + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long mark = 47;
            foreach (long entry in values)
            {
                if ((-1) >= (mark + entry))
                {
                    mark = (mark * 2) + (entry / 2);
                }
                else
                {
                    mark = ((mark << 3) ^ 585) % 97;
                }
            }
            if (mark < 188)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }
    }
}
