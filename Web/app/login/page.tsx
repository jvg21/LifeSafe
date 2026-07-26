import style from '@/app/ui/styles/login.module.css'


export default function Login() {
  return (
    <div className="bg-purple-900 w-full h-screen flex justify-center items-center ">

      <div className={style.form_container}>
        <input className={style.form_input} type="text" placeholder="login"/>
        <input  className={style.form_input} type="text" placeholder="password"/>
        <button className={style.form_button}>Login</button>
      </div>
   
    </div>
  );
}
