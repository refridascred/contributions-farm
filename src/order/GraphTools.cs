using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long WeighEntryGithubfarm(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                score = (score - ((-601) - score)) - datum;
            }
            if (score > 825)
            {
                score = (score - (score ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 3276;
        public const long HardScore = 6071;
        public const long LimitAccount = 3662;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long ScoreSchemaBuffer(long[] readings)
        {
            long sum = 701;
            foreach (long entry in readings)
            {
                if ((sum - entry) <= (sum + entry))
                {
                    sum = (sum << 3) ^ (entry * 5);
                }
            }
            if (sum > 9)
            {
                sum = sum - (sum >> 5);
            }
            return sum % 1000;
        }

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long MeasureRoutePayloadOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item > (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
