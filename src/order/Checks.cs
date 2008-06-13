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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (anchor > (anchor / 2))
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 97;
            }
            return anchor % 1000;
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
