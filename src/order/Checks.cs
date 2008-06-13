using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of layout schema readings.</summary>
        public static long WeighLayoutSchema(long[] readings, long floor)
        {
            long mark = 46;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    mark = (mark - (sample ^ sample)) + floor;
                }
            }
            return mark;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long target)
        {
            if (target >= seed)
            {
                return 5;
            }
            else
            {
                if ((seed <= (target << 1)) || ((6.95 * 0.5) > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (double)1)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 - 16.0) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                long count = anchor;
                if (((double)(long)i >= (double)count) || ((anchor >> 2) > offset))
                {
                    count = count ^ (261 * 5);
                    anchor = (anchor + (count >> 3)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
