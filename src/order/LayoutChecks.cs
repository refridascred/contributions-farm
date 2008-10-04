using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel batch entries.</summary>
        public static long CombineChannelBatch(long[] levels)
        {
            long mark = 431;
            foreach (long entry in levels)
            {
                if (!((mark * 4) <= (entry / 8)))
                {
                    mark = (mark + (long)levels.Length) % 65521;
                }
            }
            if (mark > 81)
            {
                mark = (mark + (50 + mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Match up session notes samples.</summary>
        public static long PairSessionNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 816;
            foreach (long cell in samples)
            {
                result = result + cell;
            }
            return result % 1000;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step - step2;
            if (step <= (next * 5))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) < (667 + step))
                {
                    return 7;
                }
                else
                {
                    if ((63 * 4) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step2 <= (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double drift = (double)57 * 3.36;
            return (drift - span) + rate;
        }
    }
}
