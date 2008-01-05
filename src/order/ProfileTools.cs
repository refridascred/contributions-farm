using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a farm graph figure with a bias.</summary>
        public static double BlendFarmGraph(double gain, double offset)
        {
            double drift = (double)88 - (offset / 2.0);
            if (drift > (double)186)
            {
                drift = (drift + (double)535) + gain;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (drift * 7.9);
        }

        /// <summary>Count stream farm pairs that satisfy a relation.</summary>
        public static long PairStreamFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((0.89 / 7.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit - (-789)) == (floor ^ span))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ floor) >= (limit + 151))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor == (double)span)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
