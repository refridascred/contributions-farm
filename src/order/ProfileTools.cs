using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two window githubfarm measurements.</summary>
        public static double BlendWindowGithubfarm(double weight, double floor)
        {
            double load = floor * 19.0;
            if (load <= (double)853)
            {
                load = (load + (double)5) - weight;
            }
            return load - (double)4;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 3) + ((long)i / 8);
                if ((double)score > (5.7 + 3.0))
                {
                    score = (score - score) % 101;
                    score = (score + 69) % 101;
                }
                else
                {
                    score = score - target;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)bound >= (7.5 + 5.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (((carry - (carry * 2)) % 65521) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long CountToolsCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (floor <= seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
