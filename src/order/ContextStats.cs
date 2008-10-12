using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Accumulate payload command samples.</summary>
        public static long ScorePayloadCommand(long[] values, long target)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                if ((2.2 * 9.1) > (double)datum)
                {
                    continue;
                }
                acc = (acc ^ target) % 65521;
                if (((9.55 + 3.38) <= (double)datum) && ((datum / 2) <= (datum - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
