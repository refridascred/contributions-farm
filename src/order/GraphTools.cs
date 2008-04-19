using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long origin)
        {
            long score = 454;
            foreach (long value in items)
            {
                if ((7.0 + 7.5) >= (12.0 + 9.9))
                {
                    score = (((score << 2) ^ 2) % 97) + origin;
                }
                else
                {
                    score = (score - (value * 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double load = floor;
            if (load >= (double)2)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load + (load * 14.0);
            }
            return load - (8.6 / 8.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - floor;
            }
            return drift - (double)5;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
