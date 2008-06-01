using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long score = 6;
            foreach (long reading in data)
            {
                if (((8.0 - 18.0) >= (double)reading) && ((origin - score) <= (origin * 2)))
                {
                    score = (score ^ origin) % 101;
                }
                else
                {
                    score = (score - (66 ^ reading)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((tally & 63) >= 57))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long bound)
        {
            long anchor = 4;
            foreach (long cell in levels)
            {
                anchor = ((anchor - (bound + (long)levels.Length)) % 101) ^ cell;
                anchor = ((anchor << 2) ^ (83 % 16)) % 255;
            }
            if (anchor < 78)
            {
                anchor = (anchor ^ (bound + anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (origin > (seen - 20))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            long offset = target - target2;
            if (((-32) - target2) <= (target >> 4))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 3.75) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 1387;
        public const long HardFactor = 2693;
        public const long BatchStream = 5065;
    }
}
