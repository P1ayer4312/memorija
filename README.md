# Меморија

## Опис на програмата:
Целта на оваа апликација е да се имплементира познатата игра “Меморија” со помош на Windows Forms и C# програмскиот јазик.
Меморија претставува игра каде играчот треба да ги отвори сите полиња и да ги спари сите слики. Доколку се отворат две полиња со различни слики, отворените полиња се затвораат и треба да се отворат две полиња со иста слика. Ако играчот успее да отвори две полиња со иста слика, тие полиња остануваат отворени со што играчот продолжува со спарување на останатите затворени полиња.
Изглед на играта:
 
Откако играчот ќе ја отвори играта, тајмерот ќе почне да одбројува и може да почне со игра. Со клик на ѕвездите полињата се отвораат и може да се види сликата под ѕвездата. Доколку сакаме да почнеме одново, со клик на копчето “Reset” кое се наоѓа во горниот десен агол, ќе се ресетира тајмерот и сите полиња ќе се затворат со нови скриени слики.
 
## Имплементација:
За имплементација на играта потребни ни се неколку клучни променливи:
- две променливи каде ќе се чуваат селектираните полиња (slika1, slika2)
- низа од сите полиња на екранот (slikiSite)
- променливи за чување на времето и состојбата на играта (clock, state, counter)
- контрола на времето (timer1, ShortPause)

Секое поле во себе содржи информација за себе во следниве променливи:
- Tag – ја чува локацијата на својата слика
- AccessibleDescription – ја чува состојбата за самото поле (0 = полето е затворено, 1 = полето е отворено)
Со секој клик на некое поле се повика функцијата Check_Click(). 
```c#
private void Check_Click(object sender, EventArgs e) {
    PictureBox pb = (PictureBox)sender;
    //Proveruva dali e kliknato na otvoreno pole ili prethodnite
    //polinja se seushte otvoreni i ja pauzira igrata privremeno
    if (state == 3 || pb.AccessibleDescription.Equals("1")) return;
    pb.BackgroundImage = Image.FromFile(pb.Tag.ToString());
    Check(pb);
}
```
Оваа функција проверува дали полето е отворено или доколку полињата на играта се оневозможени привремено. Доколку нема проблем и полето не е отворено, се прикажува скриената слика и се препраќа објектот на функцијата Check(). 
Функцијата Check() претставува едноставна if-else функција која ја проверува состојбата на играта и ги доделува полињата во соодветните променливи. 
```c#
public void Check(PictureBox pb) {
    pb.AccessibleDescription = "1";
    if (state == 0) {
        slika1 = pb;
        state = 1;
    } else {
        slika2 = pb;
        if (!slika1.Tag.ToString().Equals(slika2.Tag.ToString())) {
            ShortPause.Enabled = true;
            state = 3;
        } else {
            counter++;
            if (counter == 8) {
                timer1.Enabled = false;
                MessageBox.Show("You won!\nTime: " + label1.Text, "Congrats");
                return;
            }
            state = 0;
        }
    }
}
```
Откако ќе се повика функцијата Check() на пратениот објект се поставува “1” во AccessibleDescription со што кажуваме дека полето е отворено. Доколку вредноста на state е 0 пратениот објект се зачувува во променливата slika1 и state добива вредност 1, а ако state има вредност 1 пратениот објект се зачувува во slika2 и се извршува дополнителна проверка. Ако двете селектирани полиња немаат иста слика, се активира ShortPause тајмерот и state добива вредност 3 со што полињата се оневозможени 800 милисекунди. По истек на времето функцијата ShortPause_Tick() ги затвора селектираните полиња, ја променува нивната вредност за AccessibleDescription во 0 (означува дека се затворени) и овозможува останатите полињата да бидат отворени.
Доколку селектираните полиња имаат иста слика, тие полиња остануваат отворени и се зголемува вредноста за counter. Доколку counter има вредност 8, играта завршува и се прикажува порака со времето. Ако играта не е завршена, state добива вредност 0 и се повторуваат претходните чекори се до крај на играта.
 
Кога ќе се пушти играта и со секој клик на копчето “Reset”, се повикува функцијата Reset(). Оваа функција има за цел да ги ресетира сите вредности, да ги затвори сите полиња и на секое поле да додели нова слика.
```c#
public void Reset()
{
    int size = 15;
    int pick = 0;
    counter = 0;
    clock[0] = 0; 
    clock[1] = 0;
    label1.Text = "00:00";
    timer1.Enabled = true;
    Random random = new Random();
    state = 0;
    niza = new string[] {"1.jpg", "2.jpg", "3.jpg", "4.jpg","5.jpg", "6.jpg", "7.jpg", "8.jpg", 
                        "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg" };
    for (int i = 0; i < 16; i++)
    {
        slikiSite[i].BackgroundImage = Image.FromFile(".\\img\\cover.jpg");
        pick = random.Next(0, size);
        slikiSite[i].Tag = ".\\img\\" + niza[pick];
        slikiSite[i].AccessibleDescription = "0";
        niza[pick] = niza[size--];
    }
}
```
Прво, во променливата niza се чуваат имињата на сите слики кои може да се прикажат. Со for циклус за секое поле доделуваме слика по случаен избор. Со секој циклус вредностна на size се намалува и на местото на избраната рандом слика се поставува елементот со индекс size со што се намалува низата и се избегнува повторување на слики.
Останатите функции се кратки и едноставни, може лесно да се утврди што извршуваат.
