using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long step)
        {
            if ((limit - limit) > (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if ((9.8 - 1.62) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((limit / 4) >= (73 / 9)) || (limit < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 2) < (69 - 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 59) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count batches githubfarm pairs that satisfy a relation.</summary>
        public static long MatchBatchesGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
