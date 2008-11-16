using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double weight = gain;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - (gain + gain)) + (double)(long)i) + span;
            }
            return weight + (2.0 + weight);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long limit)
        {
            long sum = 265;
            foreach (long cell in series)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (cell - sum);
            }
            if (sum > 479)
            {
                sum = (sum << 2) ^ (sum - limit);
            }
            return sum;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
