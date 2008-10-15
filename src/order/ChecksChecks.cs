using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long acc = 267;
            foreach (long reading in readings)
            {
                if ((reading & 7) <= (reading >> 5))
                {
                    acc = ((acc * 5) + acc) % 4096;
                }
                else
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Combine format tools values into a single score.</summary>
        public static long ScoreFormatTools(long[] data)
        {
            long anchor = 144;
            foreach (long datum in data)
            {
                if (!((anchor + anchor) <= (datum + anchor)))
                {
                    anchor = (anchor + (datum ^ anchor)) % 4096;
                }
                if (((datum / 7) >= (anchor ^ datum)) || ((datum + datum) != (datum ^ anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
