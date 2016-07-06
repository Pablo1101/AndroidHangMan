using System;
using System.IO;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;

namespace XHangman1
{
    [Activity(Label = "Hangman")]
    public class MainActivity : Activity
    {
       
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnZ;
        private ImageView demoImageView;

        List<string> DictList = new List<string>();
        Dictionary<string, string> DictWords = new Dictionary<string, string>();
        //TextView txtviewMessage;
        List<string> colors = new List<string>();
        Random rand = new Random();
        string GameWord;
        Words mywords = new Words();
        char[] charGameWord;
        char[] charunderscore;
        private Boolean nextToLoad = true;
        private TextView txtviewmessage;
        private int count = 1;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            LoadWords();
            InitializeControls();
            PickWord();

        }
        void InitializeControls()

        {
            SetContentView(Resource.Layout.Main);

            btnA = FindViewById<Button>(Resource.Id.btnA);
            btnB = FindViewById<Button>(Resource.Id.btnB);
            btnC = FindViewById<Button>(Resource.Id.btnC);
            btnD = FindViewById<Button>(Resource.Id.btnD);
            btnE = FindViewById<Button>(Resource.Id.btnE);
            btnF = FindViewById<Button>(Resource.Id.btnF);
            btnG = FindViewById<Button>(Resource.Id.btnG);
            btnH = FindViewById<Button>(Resource.Id.btnH);
            btnI = FindViewById<Button>(Resource.Id.btnI);
            btnJ = FindViewById<Button>(Resource.Id.btnJ);
            btnK = FindViewById<Button>(Resource.Id.btnK);
            btnL = FindViewById<Button>(Resource.Id.btnL);
            btnM = FindViewById<Button>(Resource.Id.btnM);
            btnN = FindViewById<Button>(Resource.Id.btnN);
            btnO = FindViewById<Button>(Resource.Id.btnO);
            btnP = FindViewById<Button>(Resource.Id.btnP);
            btnQ = FindViewById<Button>(Resource.Id.btnQ);
            btnR = FindViewById<Button>(Resource.Id.btnR);
            btnS = FindViewById<Button>(Resource.Id.btnS);
            btnT = FindViewById<Button>(Resource.Id.btnT);
            btnU = FindViewById<Button>(Resource.Id.btnU);
            btnV = FindViewById<Button>(Resource.Id.btnV);
            btnW = FindViewById<Button>(Resource.Id.btnW);
            btnX = FindViewById<Button>(Resource.Id.btnX);
            btnY = FindViewById<Button>(Resource.Id.btnY);
            btnZ = FindViewById<Button>(Resource.Id.btnZ);
            
            txtviewmessage = FindViewById<TextView>(Resource.Id.textView1);
            demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
            
            btnA.Click += delegate
            {
                btnA.Enabled = false;
              
                count++;
                

            };
            btnB.Click += delegate
            {
                btnB.Enabled = false;
            };
            btnC.Click += delegate
            {
                btnC.Enabled = false;
            };
            btnD.Click += delegate
            {
                btnD.Enabled = false;
            };
            btnE.Click += delegate
            {
                btnE.Enabled = false;
            };
            btnF.Click += delegate
            {
                btnF.Enabled = false;
            };
            btnG.Click += delegate
            {
                btnG.Enabled = false;
            };
            btnH.Click += delegate
            {
                btnH.Enabled = false;
            };
            btnI.Click += delegate
            {
                btnI.Enabled = false;
            };
            btnJ.Click += delegate
            {
                btnJ.Enabled = false;
            };
            btnK.Click += delegate
            {
                btnK.Enabled = false;
            };
            btnL.Click += delegate
            {
                btnL.Enabled = false;
            };
            btnM.Click += delegate
            {
                btnM.Enabled = false;
            };
            btnN.Click += delegate
            {
                btnN.Enabled = false;
            };
            btnO.Click += delegate
            {
                btnO.Enabled = false;
            };
            btnP.Click += delegate
            {
                btnP.Enabled = false;
            };
            btnQ.Click += delegate
            {
                btnQ.Enabled = false;
            };
            btnR.Click += delegate
            {
                btnR.Enabled = false;
            };
            btnS.Click += delegate
            {
                btnS.Enabled = false;
            };
            btnT.Click += delegate
            {
                btnT.Enabled = false;
            };
            btnU.Click += delegate
            {
                btnU.Enabled = false;
            };
            btnV.Click += delegate
            {
                btnV.Enabled = false;
            };
            btnW.Click += delegate
            {
                btnW.Enabled = false;
            };
            btnX.Click += delegate
            {
                btnX.Enabled = false;
            };
            btnY.Click += delegate
            {
                btnY.Enabled = false;
            };
            btnZ.Click += delegate
            {
                btnZ.Enabled = false;
            };
        }
        private void LoadWords()
        {
          //tie the asset into the project;
            try
            {
                var assets = Assets;
                using (var sr = new StreamReader(assets.Open("HangManWords.txt")))
               // StreamReader sr = new StreamReader("HangManWords.txt");
                {
                    while (sr.EndOfStream)
                    {
                        var text = sr.ReadLine();

                        if (text != string.Empty && text.Length > 4) //if text is less than 4 or empty, do not use.;
                        {

                            var word = text.Remove(text.IndexOf(' '));
                            word = word.Trim();


                            if (DictWords.ContainsKey(word) && word.Length > 4)
                            {
                                DictList.Add(word); //add the word to the list


                            }

                        }
                    }
                }




            }
            catch (Exception)
            {

                Toast.MakeText(this, "Database didn't load", ToastLength.Short).Show();
            }
                  
        }

        private void PickWord()
        {
            int randomNumber = rand.Next(1, DictList.Count);
            GameWord = DictList[randomNumber];
            GameWord = GameWord.ToLower();//hghb
            GameplaySetup();
        }

        private void GameplaySetup()
        {
            charGameWord = GameWord.ToCharArray();
            charunderscore = new char[charGameWord.Length];

            for (int i = 0; i < charunderscore.Length; i++)
            {
                charunderscore[i] = '_';
            }
            //string textviewword = charunderscore.ToString();

            string textviewword = new string(charunderscore);
            //TextView textbox = new TextView();
            txtviewmessage.Text = textviewword;
            
        }

        private void afterbuttonClick(char letter)
        {

            Boolean LoadImageIsIncorrect = true;
            for (int i = 0; i < charunderscore.Length; i++)
            {
                if (letter == charGameWord[i])
                {
                    charunderscore[i] = letter;
                    LoadImageIsIncorrect = false;
                   // nextToLoad = false;
                   
                }

                //else
                //{
                //        
                 

                //    count++;
                //}

            }


            if(LoadImageIsIncorrect == true)
            {
                count++;

                switch (count)
                {
                     case 1:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;

                    case 2:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;
                    case 3:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;
                    case 4:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;
                    case 5:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;
                    case 6:
                        demoImageView = FindViewById<ImageView>(Resource.Id.demoImageView);
                        demoImageView.SetImageResource(Resource.Drawable.first);
                        break;
                }


            }



        
            }
            //if (nextToLoad == false)
            //{
            //    //increaseimage
            //    nextToLoad = true;
            //}


        }



    }







