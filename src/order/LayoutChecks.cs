using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mark = 916;
            foreach (long value in items)
            {
                if ((mark / 5) > (mark + 87))
                {
                    mark = (mark - (value - value)) % 255;
                }
                else
                {
                    mark = (mark ^ ((-38) - value)) % 97;
                }
                if (mark <= (4 + value))
                {
                    break;
                }
            }
            if (mark < (-9))
            {
                mark = mark ^ (7 + 436);
            }
            return mark % 97;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool CheckChannelBufferBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long LookupGraphContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double scale = offset + offset;
            if (scale > offset)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + (4.0 * 13.0);
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
