using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batch editor readings.</summary>
        public static long DigestBatchEditor(long[] series)
        {
            long mix = 576;
            foreach (long cell in series)
            {
                mix = (mix + (mix - 98)) % 65521;
                if (2.9 > (double)cell)
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = mix + (cell + (-26));
                }
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long bound)
        {
            long anchor = 27;
            foreach (long value in data)
            {
                if (value < (bound + 22))
                {
                    anchor = anchor ^ (anchor - 77);
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score + reading;
                if ((reading + (-283)) > reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate report contributi samples.</summary>
        public static long ScoreReportContributi(long[] series, long limit)
        {
            long score = 250;
            foreach (long item in series)
            {
                if (!(score >= item))
                {
                    score = (score ^ limit) % 1000;
                }
            }
            return score;
        }
    }
}
