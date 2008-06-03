using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if ((offset ^ offset) != (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 1) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 9.7) == (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < 1.79)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples, long step)
        {
            long score = 849;
            foreach (long reading in samples)
            {
                score = ((score * 3) + (score + score)) % 97;
                if ((reading + score) > reading)
                {
                    score = ((score << 2) ^ (score + 14)) % 255;
                }
                if ((double)reading >= (6.1 / 9.0))
                {
                    break;
                }
            }
            if (score < 80)
            {
                score = (score * 3) + step;
            }
            return score % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 5) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Paused,
            Locked,
        }
    }
}
