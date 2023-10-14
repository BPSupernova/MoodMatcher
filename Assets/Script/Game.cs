using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int categoryNum = int.MinValue; // Either from 1-8 (Starting from Happy Category, ending in Motivational Category)
    private string[] love = {"We accept the love we think we deserve.” ― Stephen Chbosky, The Perks of Being a Wallflower", "Love is that condition in which the happiness of another person is essential to your own. ― Robert A. Heinlein", "Stranger in a Strange Land", 
    "Love never dies a natural death. It dies because we don't know how to replenish its source. It dies of blindness and errors and betrayals. It dies of illness and wounds; it dies of weariness, of witherings, of tarnishings. ― Anais Nin", 
    "If I had a flower for every time I thought of you...I could walk through my garden forever. ― Alfred Tennyson", "Every heart sings a song, incomplete, until another heart whispers back. Those who wish to sing always find a song. At the touch of a lover, everyone becomes a poet. ― Plato",
    "I have decided to stick to love...Hate is too great a burden to bear. ― Martin Luther King Jr., A Testament of Hope: The Essential Writings and Speeches", "There is always some madness in love. But there is also always some reason in madness.” ― Friedrich Nietzsche", 
    "Love doesn't just sit there, like a stone, it has to be made, like bread; remade all the time, made new.” ― Ursula K. Le Guin, The Lathe of Heaven", "Love does not consist of gazing at each other, but in looking outward together in the same direction.” ― Antoine de Saint-Exupéry, Airman's Odyssey", 
    "I've learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel. — Maya Angelou"};
    private string[] joy = {"Joy is what happens to us when we allow ourselves to realize how good things really are. —Marianne Williamson", "Joy is prayer; joy is strength: joy is love; joy is a net of love by which you can catch souls. —Mother Teresa", 
    "Happiness is a gift and the trick is not to expect it, but to delight in it when it comes. —Charles Dickens", "Children are happy because they don’t have a file in their minds called ‘all the things that could go wrong. —Marianne Wiliamson", 
    "Humans were so circular; they lived the same slow cycles of joy and misery over and over, never learning. —Richelle Mead", "If you want to be successful and joyful, you must think positive, inspiring, and motivational thoughts. —Anonymous", 
    "I slept and dreamt that life was joy. I awoke and saw that life was service. I acted and behold, service was joy. —Rabindranath Tagore", "Christmas is the spirit of giving without a thought of getting. It is happiness because we see joy in people. —Thomas S. Monson", 
    "Your success and happiness lies in you. Resolve to keep happy, and your joy and you shall form an invincible host against difficulties. —Helen Keller", "Find a place inside where there’s joy, and the joy will burn out the pain. —Joseph Campbell", 
    "We are shaped by our thoughts; we become what we think. When the mind is pure, joy follows like a shadow that never leaves. —Buddha", "It is the supreme art of the teacher to awaken joy in creative expression and knowledge. —Albert Einstein", 
    "Today I choose life. Every morning when I wake up I can choose joy, happiness, negativity, pain… To feel the freedom that comes from being able to continue to make mistakes and choices - today I choose to feel life, not to deny my humanity but embrace it. —Kevyn Aucoin"};
    private string[] creative = {"Creativity is intelligence having fun. —Albert Einstein", "Creativity is contagious, pass it on. —Albert Einstein", "Creativity is a drug I cannot live without. —Cecil B. DeMille", 
    "Creativity is a type of learning process where the teacher and the pupil are located in the same individual. —Arthur Koestler", "The worst enemy to creativity is self-doubt. —Sylvia Plath", 
    "It is the child in man that is the source of his uniqueness and creativity, and the playground is the optimal milieu for the unfolding of his capacities and talents. —Eric Hoffer", "Creativity is the power to connect the seemingly unconnected. —William Plomer", 
    "Creativity is allowing yourself to make mistakes. Art is knowing which ones to keep. —Scott Adams", "Creativity is thinking up new things. Innovation is doing new things. —Theodore Levitt"};
    private string[] lonely = {"Life is either a daring adventure or nothing at all. - Helen Keller", "Yes, there is joy, fulfillment, and companionship, but the loneliness of the soul in its appalling self-consciousness is horrible and overpowering. —Sylvia Plath", 
    "Act as if what you do makes a difference. - William James", "Believe you can and you’re halfway there. - Theodore Roosevelt", "Success is a journey not a destination. - Ben Sweetland", "What you get by achieving your goals is not as important as what you become by achieving your goals. - Zig Ziglar", 
    "The best and most beautiful things in the world cannot be seen or even touched — they must be felt with the heart. - Helen Keller", "It is during our darkest moments that we must focus to see the light. - Aristotle", "Whoever is happy will make others happy too.- Anne Frank."};
    private string[] anxious = {"Anxiety is a thin stream of fear trickling through the mind. If encouraged, it cuts a channel into which all other thoughts are drained. —Arthur Somers Roche", "It’s so empowering to say ‘This isn’t serving me’ and walk away in peace. —Anonymous", 
    "Peace is the result of retraining your mind to process life as it is, rather than as you think it should be. —Wayne W. Dyer", "Everything you have ever wanted, is sitting on the other side of fear. —Anonymous", 
    "Anxiety is love’s greatest killer. It makes others feel as you might when a drowning man holds on to you. You want to save him, but you know he will strangle you with his panic. —Anais Nin", "Worry is like a rocking chair: it gives you something to do but never gets you anywhere. —Erma Bombeck", 
    "Inner peace begins the moment you choose not to allow another person or event to control your emotions. —Pema Chödrön", "Anxiety is the dizziness of freedom. —Søren Kierkegaard", "Trust yourself. You’ve survived a lot and you’ll survive whatever is coming. —Anonymous."};
    private string[] tired = {"I must be overtired', Buttercup managed. 'The excitement and all.' 'Rest then', her mother cautioned. 'Terrible things can happen when you're overtired. I was overtired the night your father proposed. - William Goldman, The Princess Bride", 
    "We all grow tired eventually; it happens to everyone. Even the sun, at the close of the year, is no longer a morning person. - Joyce Rachelle", "Sometimes exhaustion is not a result of too much time spent on something, but of knowing that in its place, no time is spent on something else. - Joyce Rachelle", 
    "Undoubtedly, our weariness is not based on the fact that we’re running. Rather, our weariness is all too frequently based on the fact that many of the things that we’re running from are the very things we should be running to. - Craig D. Lounsbrough", "You are sick and tired. I realize. But aren't you tired of feeling sick and tired - Stephen King, Doctor Sleep",
    "The threshold is not when you get tired out", "It's when you no longer care about it..! - Mahendar Singh Jakhar", "Feeling tired? Learn to rest, not to quit - Dido Stargaze", "There are many things in life worth getting temporarily tired for, but there is nothing in life worth getting permanently tired for. - George Hammond", 
    "Cure for exhaustion is not despair, but searching our memory for yesterday, then to rest deeply for an hour or two. - Monaristw", "Dear Life, I am tired of you, but I am not done with you. - Miegrat Sammri"};
    private string[] life = {"Life is either a daring adventure or nothing at all. - Helen Keller", "Love the life you live. Live the life you love. - Bob Marley", "Act as if what you do makes a difference. - William James", "Believe you can and you’re halfway there. - Theodore Roosevelt", 
    "Success is a journey not a destination. - Ben Sweetland", "What you get by achieving your goals is not as important as what you become by achieving your goals. - Zig Ziglar", "The best and most beautiful things in the world cannot be seen or even touched — they must be felt with the heart. - Helen Keller", 
    "It is during our darkest moments that we must focus to see the light. - Aristotle", "Whoever is happy will make others happy too. - Anne Frank"};
    private string[] selfLove = {"Believe in yourself. You are braver than you think, more talented than you know, and capable of more than you imagine. - Roy T. Bennett, The Light in the Heart" , "One of the greatest regrets in life is being what others would want you to be, rather than being yourself. - Shannon L. Alder", 
    "Document the moments you feel most in love with yourself  what you’re wearing, who you’re around, what you’re doing. Recreate and repeat. - Warsan Shire", "I am my own experiment. I am my own work of art. - Madonna", "The way you think about yourself determines your reality. You are not being hurt by the way people think about you. Many of those people are a reflection of how you think about yourself. - Shannon L. Alder", 
    "In your own life it's important to know how spectacular you are. - Steve Maraboli, Unapologetically You: Reflections on Life and the Human Experience", "Self love is the elixir of an immortal heart. - Amy Leigh Mercree", "Lighten up on yourself. No one is perfect. Gently accept your humanness. - Deborah Day", 
    "We can't be so desperate for love that we forget where we can always find it; within. - Alexandra Elle", "When admiring other people's gardens, don't forget to tend to your own flowers. - Sanober Khan", "Take a day to heal from the lies you’ve told yourself and the ones that have been told to you. - Maya Angelou"};

    
    public void OutputQuote() {
        switch (categoryNum) {
            case 1 : 
                System.Random rnd1 = new System.Random();
                text.text = love[rnd1.Next(0, love.Length)];
                break;
            case 2 :
                System.Random rnd2 = new System.Random();
                text.text = joy[rnd2.Next(0, joy.Length)];
                break;
            case 3 :
                System.Random rnd3 = new System.Random();
                text.text = creative[rnd3.Next(0, creative.Length)];
                break;
            case 4 :
                System.Random rnd4 = new System.Random();
                text.text = lonely[rnd4.Next(0, lonely.Length)];
                break;
            case 5 :
                System.Random rnd5 = new System.Random();
                text.text = anxious[rnd5.Next(0, anxious.Length)];
                break;
            case 6 :
                System.Random rnd6 = new System.Random();
                text.text = tired[rnd6.Next(0, tired.Length)];
                break;
            case 7 :
                System.Random rnd7 = new System.Random();
                text.text = life[rnd7.Next(0, life.Length)];
                break;
            case 8 :
                System.Random rnd8 = new System.Random();
                text.text = selfLove[rnd8.Next(0, selfLove.Length)];
                break;
            default:
                Debug.Log("Case not activated");
                break;
        }
    }
}
