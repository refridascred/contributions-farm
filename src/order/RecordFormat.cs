using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up editor graph samples.</summary>
        public static long PairEditorGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (((sample / 7) != (sample - 9)) && (offset >= (anchor ^ anchor)))
                {
                    anchor = anchor - (sample - offset);
                }
                else
                {
                    anchor = (anchor + ((long)samples.Length - 95)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double floor)
        {
            double scale = floor * 20.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + floor) + (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long StepFarmBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset > ((long)i % 10))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
