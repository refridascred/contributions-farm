using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit window batch readings against a rule.</summary>
        public static long CountWindowBatchHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (200 <= seen)
                {
                    seen = ((seen + 2) + reading) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double rate = (double)(801 % 2);
            if (rate > (3.9 + scale))
            {
                rate = (rate + (17.0 + rate)) + offset;
            }
            else
            {
                rate = rate + (double)742;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)729) - (double)(long)i;
            }
            return rate - (4.3 * 5.4);
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long SeriesContextCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + limit) % 255;
                score = (score - (score * 3)) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
