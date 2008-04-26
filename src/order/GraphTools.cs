using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the stream window series from a seed.</summary>
        public static long RollStreamWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result * 4) + (result & 255);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a route queue sample.</summary>
        public static long SeekRouteQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long seed2)
        {
            if ((double)seed2 >= (9.08 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((83 + 721) == (seed2 - seed))
                {
                    return 6;
                }
                else
                {
                    if (((seed2 + seed2) <= seed) || ((double)seed <= 3.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((4.8 - 18.0) < (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
