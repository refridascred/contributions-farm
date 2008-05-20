using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double scale = (double)((-629) >> 3);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + 2.48) + (double)(long)i) - rate) - bias;
            }
            return scale + 3.34;
        }
    }
}
