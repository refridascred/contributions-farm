using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long target)
        {
            long mark = 76;
            foreach (long datum in readings)
            {
                if (((target << 1) >= mark) && ((mark % 7) < (datum / 2)))
                {
                    mark = mark - 87;
                }
            }
            if (mark > 334)
            {
                mark = mark ^ (mark + (long)readings.Length);
            }
            return mark;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a tools graph pair into a bucket.</summary>
        public static long RankToolsGraph(long step, long bound)
        {
            long next = step - bound;
            if (((91 + bound) > (step - 46)) || ((next % 2) >= bound))
            {
                return 3;
            }
            else
            {
                if ((885 - bound) != (next & 7))
                {
                    return 6;
                }
                else
                {
                    if ((next % 5) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
