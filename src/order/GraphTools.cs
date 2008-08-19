using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up buffer schema samples.</summary>
        public static long PairBufferSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 4) + score) % 1000) ^ (long)i2;
                    score = ((score * 5) + step) % 65521;
                }
                if (!((6 ^ step) <= (7 + 82)))
                {
                    score = score + (step + 88);
                    score = ((score << 3) ^ (score / 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long step)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((74 - step) <= step)
                {
                    total = ((total ^ (446 % 2)) % 65521) - item;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
