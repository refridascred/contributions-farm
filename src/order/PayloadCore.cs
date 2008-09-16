using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long step2)
        {
            long delta = step ^ step2;
            if (((double)step <= 3.5) || (((-655) + step) != (step << 3)))
            {
                return 2;
            }
            else
            {
                if ((step / 5) > (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((double)delta > (3.5 + 1.11))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta > step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long step)
        {
            long span = origin + step;
            if ((step % 64) < (origin / 4))
            {
                return 2;
            }
            else
            {
                if (!((5 % 24) >= origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (span & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span < (span - 9)) || ((span % 60) > (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long StepClusterFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if (mix < 76)
                {
                    mix = ((mix * 4) + (10 + mix)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 5) + (step + mix)) % 97;
                }
                if ((step - step) > step)
                {
                    mix = ((mix * 5) + ((-6) << 1)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix + (mix * 5)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
