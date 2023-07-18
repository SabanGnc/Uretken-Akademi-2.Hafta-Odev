# Uretken-Akademi-2.Hafta-Odev

![Soft Pastel Sade Temiz Takvimli Masaüstü Düzenleyici (3)](https://github.com/SabanGnc/Uretken-Akademi-2.Hafta-Odev/assets/139702707/01473139-ae5d-4930-b092-664205a53a6b)

# Kodu isterseniz indirip test edebilir, isterseniz de aşağıdaki kısımdan bakabilirsiniz. 😊

```
void Start()
    {
        bolenleriBul(1, 20);
    }

    public void bolenleriBul(int ilksayi, int ikincisayi)
    {
        UnityEngine.Debug.Log("1. aşama:");
        string aşama1 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            aşama1 += i + "-";
        }
        UnityEngine.Debug.Log(aşama1.TrimEnd('-'));

        UnityEngine.Debug.Log("\n2. aşama:");
        string aşama2 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 2 == 0)
                aşama2 += i + "-";
        }
        UnityEngine.Debug.Log(aşama2.TrimEnd('-'));

        UnityEngine.Debug.Log("\n3. aşama:");
        string aşama3 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 3 == 0)
                aşama3 += i + "-";
        }
        UnityEngine.Debug.Log(aşama3.TrimEnd('-'));

        UnityEngine.Debug.Log("\n4. aşama:");
        string aşama4 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 4 == 0)
                aşama4 += i + "-";
        }
        UnityEngine.Debug.Log(aşama4.TrimEnd('-'));

        UnityEngine.Debug.Log("\n5. aşama:");
        string aşama5 = "";
        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            if (i % 5 == 0)
                aşama5 += i + "-";
        }
        UnityEngine.Debug.Log(aşama5.TrimEnd('-'));
    }
```

<div align="center">
  <a href="https://github.com/SabanGnc">
    <img src="https://github.com/SabanGnc/SabanGnc/assets/139702707/cc75e47a-eda0-498f-bc38-1a9a3e6ea37c" alt="Github Stats" width="1200">
  </a>
</div>


<h3 align="center">Connect with me:</h3> 
<p align="center">
  📧 Email: sabangenc95@gmail.com<br>
  💬 Discord: @vespagnc<br>
</p>
