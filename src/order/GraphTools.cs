using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel metric samples.</summary>
        public static long CombineChannelMetric(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                if (((mix * 4) >= mix) || (reading > ((long)readings.Length + 2)))
                {
                    mix = (mix - (mix % 12)) % 4096;
                }
                if ((seed - mix) <= seed)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long anchor = -646;
            foreach (long reading in samples)
            {
                if (!((539 - (long)samples.Length) <= anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if (((anchor ^ reading) >= (anchor / 2)) || ((double)anchor == (0.3 - 9.0)))
                {
                    anchor = anchor + (reading << 1);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
