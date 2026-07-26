import style from '@/app/ui/styles/layout.module.css'
import Link from 'next/link';

export default function Layout({
    children,
}: Readonly<{
    children: React.ReactNode;
}>) {
    return (

        // bgdiv
        <div className={"h-screen w-full"}>
            {/* conteiner-div */}
            {/* <div>topbar</div> */}
            <div className={"bg-red-200 flex flex-row h-full w-full"}>
                <div className={style.sidebar}>
                    <ul>
                        <li><Link href={'./book'}>Books</Link></li>
                        <li><Link href={'./note'}>Notes</Link></li>
                        <li><Link href={'./music'}>Music</Link></li>
                        <li><Link href={'./cartoon'}>Cartoons</Link></li>
                        <li><Link href={'./game'}>Games</Link></li>
                        <li><Link href={'./links'}>Links</Link></li>
                        <li><Link href={'./docs'}>Docs</Link></li>
                    </ul>
                </div>

                {/* content */}
                <div className='h-full w-full'>
                    {children}
                </div>


            </div>
        </div>
    );
}