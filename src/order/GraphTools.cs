using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a commits layout reading.</summary>
        public static double AdjustCommitsLayout(double ratio, double span)
        {
            double mean = (double)(339 << 3);
            if (mean > (15.0 - ratio))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + (mean + 0.96);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits / 3) > cell) || ((double)cell > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) < value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items)
        {
            long score = 515;
            foreach (long entry in items)
            {
                score = ((score ^ (44 * 5)) % 101) ^ entry;
            }
            return score;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
