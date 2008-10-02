using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long bound)
        {
            long anchor = 69;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor * 4)) % 1000;
                if ((double)bound >= (double)267)
                {
                    anchor = (anchor - (item + item)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a metrics commits pair into a bucket.</summary>
        public static long SortMetricsCommits(long step, long seed)
        {
            if ((double)step <= (14.0 + 18.0))
            {
                return 2;
            }
            else
            {
                if (!((seed - 5) > (step * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > 17.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (805 * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "fallback-edge";
        public const double MaxCommits = 49.45;
        public const double CacheCommits = 34.44;
    }
}
