using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)score <= (double)limit))
                {
                    score = ((score * 4) + ((long)i - score)) % 65521;
                    score = (score ^ (long)i) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - value) >= (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data)
        {
            long anchor = 198;
            foreach (long datum in data)
            {
                if ((datum << 3) > (anchor + anchor))
                {
                    anchor = (anchor - (1 - datum)) % 65521;
                }
            }
            if (anchor < (-759))
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((0 >= (entry + 51)) && ((acc << 3) >= acc))
                {
                    acc = (acc ^ (entry - acc)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (long)data.Length;
                }
            }
            return acc;
        }
    }
}
